using System.Data.Entity;
using SimpleInjector;

namespace Model
{
    public static class SingletonContext
    {
        private static Container _container = null;

        public static void CreateInstance()
        {
            Bootstrap();
        }

        private static void Bootstrap()
        {
            if (_container != null) return;

            _container = new Container();
            _container.Register<DbContext, Context>();
        }

        public static Context GetContext()
        {
            var context = _container.GetInstance<Context>();
            return context;
        }
    }
}
