namespace org.neonlabs.compatibility
{
    using dotenv.net;

    public class Config
    {
        public Config()
        {
            DotEnv.Load();
        }
    }
}