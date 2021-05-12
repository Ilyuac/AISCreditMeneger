using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WindowsFormsApp.Models
{
    public static class ProviderFactory
    {
        public static IProviderDatabase GetLinqToDbProvider()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnectonString"].ConnectionString;
            IProviderDatabase provider = new LinqToDbProvider(connectionStr);
            return provider;
        }

        public static IProviderDatabase GetListProvider()
        {
            return null;
        }
    }
}
