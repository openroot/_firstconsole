namespace _firstnamespace
{
    public class _gateway
    {
        // boat name
        private readonly string _name;

        _gateway()
        {
            this._name = this.GetType()?.Namespace ?? "";
        }

        /// <summary>invoker</summary>
        /// <param name="args">ascii character can be passed as arguments as somekinda space separated strings</param>
        /// <example>
        /// dotnet run hi hello passiba [say dotnet run is the device-in-sight to first the operating system]
        /// </example>
        private static void Main(string[] args)
        {
            _gateway _boat = new _gateway();

            // preparing sample log
            string _heard = string.Empty;

            _heard += _boat._name;
            if (args.Length > 0) {
                _heard += "\n+" + "args: ," + string.Join(" ,", args);
            }
            _heard += "\n+" + "strange easy world";

            // log exerted, say terminal for this instance
            Console.WriteLine(_heard);
        }
    }
}
