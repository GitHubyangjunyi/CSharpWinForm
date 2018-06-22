using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace ProcessAndThread
{
    public partial class FormProcessAndThread : Form
    {
        public FormProcessAndThread()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//应用程序采取非线程安全方式所以要禁用此异常
            //关于为何禁用此异常原因在下面
        }

        private Thread thread_CounterOne = null;//这两个线程对象用于线程计数器
        private Thread thread_CounterTwo = null;
        private Thread thread_LockOne = null;//这两个线程对象用于Lock测试
        private Thread thread_LockTwo = null;
        private Thread thread_MonitorOne = null;//这两个线程对象用于Monitor类测试
        private Thread thread_MonitorTwo = null;
        private Thread thread_MutexOne = null;//这两个线程对象用于Mutex类测试
        private Thread thread_MutexTwo = null;
        private Mutex mutexOne = new Mutex();//直接实例化Mutex(互斥器)对象
        private Thread thread_Produce = null;//这两个线程对象用于生产和装运线程对象
        private Thread thread_Convey = null;
        static object product = new object();//创建一个互斥体对象令牌
        int iMaxProduct = 10;//最大生产数
        int iNewProduct = 0;//待装数量
        int iConvey = 0;//已装运数量
        bool blStopProduce = false;//停止生产和装运标记

        private void Btn_StartPowerShellOne_Click(object sender, EventArgs e)
        {
            ProcessOne.Start();
        }

        private void Btn_StartPowerShellTwo_Click(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe");
            if (finfo.Exists)
            {
                Process prcsPowerShell = new Process();//实例化一个Process类并启动一个独立进程
                prcsPowerShell.StartInfo.FileName = finfo.FullName;//指定启动的程序文件
                prcsPowerShell.Start();
            }
            else
            {
                MessageBox.Show("文件" + finfo.FullName + "不存在");
            }
        }
        
        private void Btn_StopPowerShell_Click(object sender, EventArgs e)
        {
            Process[] cp;//创建一个Process组件的数组
            cp = Process.GetProcessesByName("Windows PowerShell");//将数组与指定名称的所有进程相关联
            foreach (Process item in cp)//遍历当前启动程序并查找包含指定名称的进程
            {
                item.Close();//终止当前进程关闭窗体
            }
        }

        private void CounterOne()
        {
            while (true)
            {
                int i;
                for (i = 0; i < 1000; i++)
                {
                    Tb_CounterOne.Text = i.ToString();
                }
                Thread.Sleep(3000);//线程休眠3秒
            }
        }

        private void CounterTwo()
        {
            while (true)
            {
                int j;
                for (j = 0; j < 1000; j++)
                {
                    Tb_CounterTwo.Text = j.ToString();
                }
                Thread.Sleep(3000);//线程休眠3秒
            }
        }

        private void ShowChar(char ch)
        {
            //使用lock将代码区标记为一个临界区,确保当一个线程位于代码临界区时,另一线程不进入该临界区
            //如果其他线程试图进入该临界区时,它将一直等待,直到该对象被释放
            //其执行过程是先获得给定对象的互斥锁然后执行相应语句,任务完成后再释放该锁
            //通常应避免锁定public类型的对象,否则实例将超出代码的控制范围
            //最佳做法是定义private对象来锁定,或定义private static对象变量来保护所有实例的共有数据
            lock (this)
            {
                Rtb_ShowCharOne.Text += ch;
            }
            //ShowCharRichBox.Text += ch;
            //不进行lock结果不一样
        }

        private void Thread_Lock_ShowCharOne()
        {
            while (true)
            {
                ShowChar('A');
                Thread.Sleep(300);//A任务的线程休眠时间只有X任务的一半
            }
        }

        private void Thread_Lock_ShowCharTwo()
        {
            while (true)
            {
                ShowChar('X');
                Thread.Sleep(600);
            }
        }

        private void Thread_Monitor_ShowCharOne()//Monitor监视器
        {
            while (true)
            {
                //Monitor.Enter(this.Rtb_ShowCharTwo);
                //try
                //{
                //    Rtb_ShowCharTwo.Text += "B";
                //}
                //catch (Exception)
                //{
                //    Monitor.Exit(this.Rtb_ShowCharTwo);
                //}
                //Monitor.Exit(this.Rtb_ShowCharTwo);//也可以锁定局部资源ShowCharRichBox2
                Monitor.Enter(this);//在指定对象上获取排他锁
                try
                {
                    Rtb_ShowCharTwo.Text += "B";
                    Monitor.Exit(this);//这句必须有不然调试生成显示不出来,放这竟然也可以
                    //Monitor.Enter(this);//这句不注释掉会使Rtb_ShowCharOne和Rtb_ShowCharTwo不按预期工作
                    //注意是Rtb_ShowCharOne和Rtb_ShowCharTwo不按预期工作
                }
                catch (Exception)
                {
                    Monitor.Exit(this);//释放指定对象上的排他锁
                }
                Thread.Sleep(300);
            }
        }

        private void Thread_Monitor_ShowCharTwo()//Monitor监视器
        {
            while (true)
            {
                //Monitor.Enter(this.Rtb_ShowCharTwo);
                //try
                //{
                //    Rtb_ShowCharTwo.Text += "Y";
                //}
                //catch (Exception)
                //{
                //    Monitor.Exit(this.Rtb_ShowCharTwo);
                //}
                //Monitor.Exit(this.Rtb_ShowCharTwo);//也可以锁定局部资源到Rtb_ShowCharTwo
                Monitor.Enter(this);//在指定对象上获取排他锁
                try
                {
                    Rtb_ShowCharTwo.Text += "Y";
                    //Monitor.Enter(this);//这句放这调试生成显示不出来
                }
                catch (Exception)
                {
                    Monitor.Exit(this);//释放指定对象上的排他锁
                }
                Monitor.Exit(this);//这句必须有不然调试生成显示不出来,这句放catch后是书上的
                Thread.Sleep(600);
            }
        }

        private void Thread_Mutex_ShowCharOne()
        {
            while (true)
            {
                //以下为原版代码实现
                //mutexOne.WaitOne();
                //try
                //{
                //    Rtb_ShowCharThree.Text += "C";
                //}
                //catch (Exception)
                //{
                //    mutexOne.ReleaseMutex();
                //}
                //mutexOne.ReleaseMutex();
                //Thread.Sleep(300);
                mutexOne.WaitOne();//这个方法用来捕获互斥对象,阻止当前线程直到当前System.Threading.WaitHandle收到信号
                try
                {
                    Rtb_ShowCharThree.Text += "C";
                    mutexOne.ReleaseMutex(); //这句注释掉调试生成还会显示出来,但是Rtb_ShowCharThree只会显示C,放这竟然也可以
                    //mutexOne.WaitOne();//这句不注释掉会使Rtb_ShowCharThree只会显示C并在某些情况下不停止线程就关闭窗体会抛出异常
                }
                catch (Exception)
                {
                    mutexOne.ReleaseMutex();//这个方法用来释放被捕获的对象
                }
                Thread.Sleep(300);
                //在使用方法上,Mutex与Monitor类似,但是由于Mutex不具备Wait()和Pulse()以及PulseALL()的方法
                //因此不能实现类似Monitor的唤醒功能
                //另外由于互斥体Mutex属于内核对象,进行线程同步时,线程须在用户模式与内核模式之间切换
                //所有需要互操作转换较消耗资源,效率较低
                //不过Mutex有个优点,Mutex是跨进程的,可以在同一台机器甚至远程机器上使用同一个互斥体
            }
        }

        private void Thread_Mutex_ShowCharTwo()
        {
            while (true)
            {
                //以下为原版代码实现
                //mutexOne.WaitOne();
                //try
                //{
                //    Rtb_ShowCharThree.Text += "Z";
                //}
                //catch (Exception)
                //{
                //    mutexOne.ReleaseMutex();
                //}
                //mutexOne.ReleaseMutex();
                //Thread.Sleep(600);
                mutexOne.WaitOne();//这个方法用来捕获互斥对象,阻止当前线程直到当前System.Threading.WaitHandle收到信号
                try
                {
                    Rtb_ShowCharThree.Text += "Z";
                }
                catch (Exception)
                {
                    mutexOne.ReleaseMutex();
                }
                mutexOne.ReleaseMutex();//这个方法用来释放被捕获的对象,这句再一次放catch后是书上的
                Thread.Sleep(600);
                //在使用方法上,Mutex与Monitor类似,但是由于Mutex不具备Wait()和Pulse()以及PulseALL()的方法
                //因此不能实现类似Monitor的唤醒功能
                //另外由于互斥体Mutex属于内核对象,进行线程同步时,线程须在用户模式与内核模式之间切换
                //所有需要互操作转换较消耗资源,效率较低
                //不过Mutex有个优点,Mutex是跨进程的,可以在同一台机器甚至远程机器上使用同一个互斥体
            }
        }

        private void Produce()//生产线程调用的方法
        {
            while (!blStopProduce)
            {
                lock (product)//理解为获得这个对象使用权才可以运行下面的代码,可以将这个改成锁定当前窗体this,会产生其他线程运行缓慢的情况
                {
                    for (int i = 1; i <= iMaxProduct; i++)
                    {
                        //这个for不会一次执行到条件不成立为止,执行一次就保存当前线程状态然后释放锁定的对象
                        //锁定的对象product释放后就可以给其他线程使用
                        this.Lb_Production.Items.Add(i.ToString());
                        iNewProduct++;
                        this.Lable_Convey.Text = iNewProduct.ToString();
                        if (i == iMaxProduct)
                        {
                            this.Lb_Production.Items.Add("生产结束");
                            blStopProduce = true;
                        }
                        Thread.Sleep(1000);
                        Monitor.Pulse(product);//通知等待队列中的线程锁定对象状态的更改
                        Monitor.Wait(product);//释放对象上的锁并阻止当前线程,直到它重新获取该锁
                        //方法wait()的作用是使当前执行代码的线程进行等待,并在wait()所在代码行处停止直到接到通知或者线程被中断为止
                        //可以尝试把上面两句注释掉再运行,程序将不按预期
                        //或者放到for语句外面,那将会导致程序将不按预期
                        //Monitor提供了与lock类似的功能,通过向单个线程授予对象锁来控制对该对象的访问
                        //与lock相比,lock的代码块就相当于Monitor的Ente()和Exit()方法的封装
                        //lock更简洁,但是Monitor能更好控制同步块
                        //因为在Monitor中可以通过Pulse()和PulseALL()方法向一个或多个等待线程发送信号
                        //该信号通知等待线程锁定对象的状态已更改,并且锁的所有者准备释放该锁
                        //等待线程被放置在对象的就绪队列中以便可以最后接收该锁
                        //一旦线程拥有了锁就可以检查对象的新状态已查看是否达到所需状态
                        //Wait()方法则释放对象上的锁以便允许其他线程锁定和访问该对象
                    }
                    //Monitor.Pulse(product);
                    //Monitor.Wait(product);
                }
            }
        }

        private void Fuction_Convey()//装运线程调用的方法
        {
            while (true)
            {
                lock (product)//理解为获得这个对象使用权才可以运行下面的代码,可以将这个改成锁定当前窗体this,会产生其他线程运行缓慢的情况
                {
                    iConvey = iConvey + iNewProduct;
                    this.Lb_Convey.Items.Add(iConvey.ToString());
                    iNewProduct--;
                    this.Lable_Convey.Text = iNewProduct.ToString();
                    if (blStopProduce)
                    {
                        this.Lb_Convey.Items.Add("装运完成");
                    }
                    Thread.Sleep(1000);
                    Monitor.Pulse(product);//Pulse(脉搏)通知等待队列中的线程锁定对象状态的更改
                    Monitor.Wait(product);//释放对象上的锁并阻止当前线程,直到它重新获取该锁
                    //可以尝试把上面两句注释掉再运行,程序将不按预期
                    //Monitor提供了与lock类似的功能,通过向单个线程授予对象锁来控制对该对象的访问
                    //与lock相比,lock的代码块就相当于Monitor的Ente()和Exit()方法的封装
                    //lock更简洁,但是Monitor能更好控制同步块
                    //因为在Monitor中可以通过Pulse()和PulseALL()方法向一个或多个等待线程发送信号
                    //该信号通知等待线程锁定对象的状态已更改,并且锁的所有者准备释放该锁
                    //等待线程被放置在对象的就绪队列中以便可以最后接收该锁
                    //一旦线程拥有了锁就可以检查对象的新状态已查看是否达到所需状态
                    //Wait()方法则释放对象上的锁以便允许其他线程锁定和访问该对象
                }
            }
        }

        private void Btn_StopAllThread_Click(object sender, EventArgs e)
        {
            this.Btn_RestartAllThread.Enabled = true;
            this.Btn_StopAllThread.Enabled = false;
            thread_CounterOne.Abort();
            thread_CounterTwo.Abort();
            thread_LockOne.Abort();
            thread_LockTwo.Abort();
            thread_MonitorOne.Abort();
            thread_MonitorTwo.Abort();
            thread_MutexOne.Abort();
            thread_MutexTwo.Abort();
            thread_Produce.Abort();
            thread_Convey.Abort();
            this.Rtb_ShowCharOne.Text = "";
            this.Rtb_ShowCharTwo.Text = "";
            this.Rtb_ShowCharThree.Text = "";
            this.Lb_Production.Items.Clear();
            this.Lb_Production.Items.Add("0");
            this.Lb_Convey.Items.Clear();
            this.Lb_Convey.Items.Add("0");
            this.Lable_Convey.Text = "0";
            iNewProduct = 0;//清零待装数量
            iConvey = 0;//清零已装运数量
            blStopProduce = false;//停止生产和装运标记
        }

        private void Btn_RestartAllThread_Click(object sender, EventArgs e)
        {
            this.Btn_RestartAllThread.Enabled = false;
            this.Btn_StopAllThread.Enabled = true;
            thread_CounterOne = new Thread(new ThreadStart(CounterOne));
            thread_CounterTwo = new Thread(new ThreadStart(CounterTwo));
            thread_CounterOne.Start();
            thread_CounterTwo.Start();
            thread_LockOne = new Thread(new ThreadStart(Thread_Lock_ShowCharOne));
            thread_LockTwo = new Thread(new ThreadStart(Thread_Lock_ShowCharTwo));
            thread_LockOne.Start();
            thread_LockTwo.Start();
            thread_MonitorOne = new Thread(new ThreadStart(Thread_Monitor_ShowCharOne));
            thread_MonitorTwo = new Thread(new ThreadStart(Thread_Monitor_ShowCharTwo));
            thread_MonitorOne.Start();
            thread_MonitorTwo.Start();
            thread_MutexOne = new Thread(new ThreadStart(Thread_Mutex_ShowCharOne));
            thread_MutexTwo = new Thread(new ThreadStart(Thread_Mutex_ShowCharTwo));
            thread_MutexOne.Start();
            thread_MutexTwo.Start();
            thread_Produce = new Thread(new ThreadStart(Produce));
            thread_Convey = new Thread(new ThreadStart(Fuction_Convey));
            thread_Produce.Start();
            thread_Convey.Start();
        }

        private void FormProcessAndThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread_CounterOne != null)
            {
                thread_CounterOne.Abort();
            }
            if (thread_CounterTwo != null)
            {
                thread_CounterTwo.Abort();
            }
            if (thread_LockOne != null)
            {
                thread_LockOne.Abort();
            }
            if (thread_LockTwo != null)
            {
                thread_LockTwo.Abort();
            }
            if (thread_MonitorOne != null)
            {
                thread_MonitorOne.Abort();
            }
            if (thread_MonitorTwo != null)
            {
                thread_MonitorTwo.Abort();
            }
            if (thread_MutexOne != null)
            {
                thread_MutexOne.Abort();
            }
            if (thread_MutexTwo != null)
            {
                thread_MutexTwo.Abort();
            }
            if (thread_Produce != null)
            {
                thread_Produce.Abort();
            }
            if (thread_Convey != null)
            {
                thread_Convey.Abort();
            }
        }

        private void FormProcessAndThread_Load(object sender, EventArgs e)
        {
            this.Btn_RestartAllThread.Enabled = false;
            thread_CounterOne = new Thread(new ThreadStart(CounterOne));
            thread_CounterTwo = new Thread(new ThreadStart(CounterTwo));
            thread_CounterOne.Start();
            thread_CounterTwo.Start();
            thread_LockOne = new Thread(new ThreadStart(Thread_Lock_ShowCharOne));
            thread_LockTwo = new Thread(new ThreadStart(Thread_Lock_ShowCharTwo));
            thread_LockOne.Start();
            thread_LockTwo.Start();
            thread_MonitorOne = new Thread(new ThreadStart(Thread_Monitor_ShowCharOne));
            thread_MonitorTwo = new Thread(new ThreadStart(Thread_Monitor_ShowCharTwo));
            thread_MonitorOne.Start();
            thread_MonitorTwo.Start();
            thread_MutexOne = new Thread(new ThreadStart(Thread_Mutex_ShowCharOne));
            thread_MutexTwo = new Thread(new ThreadStart(Thread_Mutex_ShowCharTwo));
            thread_MutexOne.Start();
            thread_MutexTwo.Start();
            thread_Produce = new Thread(new ThreadStart(Produce));
            thread_Convey = new Thread(new ThreadStart(Fuction_Convey));
            thread_Produce.Start();
            thread_Convey.Start();
            //线程调用start方法后并不是已经开始运行
            //调用这个方法后系统开始分配一些资源使这个线程进入可运行状态
            //一个线程正真什么时候运行是cpu决定的,我们控制不了,我们只可以设置线程的优先级,优先级高的一般会先执行
            //在C#中使用Thread类创建线程时,只需提供线程入口即可
            //线程入口是由ThreadStart代理delegate提供的
            //可以把ThreadStart理解成一个指针,指向线程要执行的函数
            //线程启动时执行ThreadStart说指向的函数
            //休眠线程Sleep()
            //挂起线程Suspend()方法用来挂起线程,如果线程已经被挂起,此方法不起作用
            //回复线程Resume()方法用来继续执行线程,如果线程未被挂起,此方法不起作用
            //终止线程Interrupt()方法用来终止处于Wait/Sleep或Join状态的线程
            //阻塞线程Join()方法用来阻塞调用线程,直到线程终止为止
            //线程从创建开始一定处于某种状态,当线程被创建时处于Unstart状态,Start方法将其变成Running状态
            //一旦线程被终止或销毁,线程将处于Stopped状态,此时线程不复存在
            //线程还有一个Background状态,表明线程处于后台还是前台
        }
    }
}
//进程:Windows是一个多任务操作系统,其中每个正在运行的程序都是一个进程
//线程:对于同一个进程,又可以分为若干个独立的执行流,这样的流被称为线程,每个进程至少包含一个线程
//线程是操作系统为其分配处理器时间的基本单位,可以独立占用处理器时间片
//同一进程中的线程可以共享该进程的资源和内存空间
//访问Windows窗体控件本质上不是线程安全的,如果由两个或多个线程同时操作某一控件时
//可能会使控件进入一种不一致的状态,还可能出现争用和死锁
//在C#中也可以采用非线程安全的方法访问窗体控件,.NET Framework有助于在以非线程安全方式访问窗体控件时发现问题
//在调试器中运行程序时,如果在创建某控件的线程之外的其他线程试图直接调用该控件,调试器就会引发InvalidOperationException异常
//警告对控件的调用不是线程安全的,所以在此应用程序一开始就禁用了CheckForIllegalCrossThreadCalls异常