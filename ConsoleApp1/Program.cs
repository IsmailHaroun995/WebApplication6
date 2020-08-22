using LOGIC.UserLogic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            UserLogic UL = new UserLogic();
            await UL.GetAllUser();

            //await UL.DeleteById();
        }
    }
}
