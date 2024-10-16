using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session11.Solid.DIP
{
    public class MyDbcontext:DbContext
    {

    }
    public class MongoRepository: IEFRepository
    {
        public int Get()
        {
            return 1;
        }
    }
    public class EFRepository : IEFRepository
    {
        private readonly MyDbcontext _myDbcontext;
        public EFRepository(MyDbcontext myDbcontext)
        {
            _myDbcontext = myDbcontext;
        }

        public int Get()
        {
            return 1;
        }
    }
    public class Client
    {
        public void CheckUseRepository()
        {
            //MyDbcontext dbcontext = new MyDbcontext();
            //EFRepository eFRepository = new EFRepository(dbcontext);
            var repository = ObjectFactory.GetRepository(); /*new MongoRepository();*/

            var result = repository.Get();
        }
    }

    public static class ObjectFactory
    {
        public static IEFRepository GetRepository()
        {
            //return new MongoRepository();
            MyDbcontext dbcontext = new MyDbcontext();
            EFRepository eFRepository = new EFRepository(dbcontext);
            return eFRepository;
        }
    }
}
