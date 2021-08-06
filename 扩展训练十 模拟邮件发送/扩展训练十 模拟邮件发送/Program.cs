using System;

namespace 扩展训练十_模拟邮件发送
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----模拟邮件发送------");
            bool recFlag = true;
            string strReceivers;
            string[] strReceiver;
            do
            {
                Console.WriteLine("\n请输入收件人（多个收件人中间用逗号<,>隔开）:");
                strReceivers = Console.ReadLine();
                strReceiver = strReceivers.Split(new char[] { ',' });
                for (int i = 0; i < strReceiver.Length; i++)
                {
                    if (strReceiver[i].IndexOf("@") == -1)
                    {
                        Console.WriteLine("\n收件人输入错误，请重新输入！");
                        break;
                    }
                    else
                    {
                        if (i == strReceiver.Length - 1)
                        {
                            recFlag = false;
                            break;
                        }
                    }
                }
            } while (recFlag);

            Console.Write("\n请输入邮件主题：");
            string strBody = Console.ReadLine();
            Console.WriteLine("\n请输入邮件内容：");
            string strContent = Console.ReadLine();
            Console.WriteLine("\n邮件发送成功，预览信息：");
            Console.WriteLine("\n收件人列表：");
            for (int i = 0; i < strReceiver.Length; i++)
            {
                Console.Write(strReceiver[i] + "   ");
            }
            Console.WriteLine("\n邮件主题：" + strBody);
            Console.WriteLine("邮件内容：");
            Console.WriteLine("   " + strContent);
            Console.WriteLine(string.Format("发送时间：{0:F}", DateTime.Now));
            Console.ReadLine();
        }
    }
}
