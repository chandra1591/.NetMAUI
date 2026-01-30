using MyMAUIApp.Models;
using SQLite;

namespace MyMAUIApp.Services
{


    public class CarService
    {

        private SQLiteConnection conn;
        private readonly string _dbPath;
        int result = 0;

        public string StatusMessage { get; private set; } = "";

        public CarService(string dbpath)
        {

            _dbPath = dbpath ?? throw new ArgumentNullException(nameof(dbpath));
            Console.WriteLine($"DB PATH => {_dbPath}");

        }
        private void Init()
        {
            if (conn != null) return;

            try
            {

                var dir = Path.GetDirectoryName(_dbPath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                // Use flags for safety in Android
                conn = new SQLiteConnection(_dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex);

                conn.CreateTable<Car>();
            }
            catch (Exception ex)
            {

                StatusMessage = "SQLite initialization failed: " + ex;
                System.Diagnostics.Debug.WriteLine(StatusMessage);
                throw;

            }
        }

        public void AddCar(Car car)
        {
            try
            {
                Init();
                if (car == null)
                {
                    throw new Exception("Invalid car record");
                }

                result = conn.Insert(car);
                StatusMessage = result == 0 ? "Insert Failed" : "Insert Successfully";

            }
            catch (Exception)
            {
                StatusMessage = "Failed to inset data";
            }
        }

        public int DeleteCar(int Id)
        {

            try
            {
                Init();
                return conn.Table<Car>().Delete(c => c.Id == Id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data";
            }
            return 0;

        }

        public List<Car> GetCars()
        {
            try
            {
                Init();
                return conn.Table<Car>().ToList();
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data";
            }
            return new List<Car>();
            //{
            //    new Car { Id = 1, Make = "Honda", Model = "Fit", Vin = "123" },
            //    new Car { Id = 2, Make = "Toyota", Model = "Prado", Vin = "123" },
            //    new Car { Id = 3, Make = "Honda", Model = "Civic", Vin = "123" },
            //    new Car { Id = 4, Make = "Audi", Model = "A5", Vin = "123" },
            //    new Car { Id = 5, Make = "BMW", Model = "M3", Vin = "123" },
            //};
        }

        public Car GetCar(int Id)
        {
            Init();

            return conn.Table<Car>().FirstOrDefault(c => c.Id == Id);
        }

        public void UpdateCar(Car car)
        {
            try
            {
                Init();
                if (car == null)
                {
                    throw new Exception("Invalid car record");
                }

                result = conn.Update(car);
                StatusMessage = result == 0 ? "Update Failed" : "Update Successfully";

            }
            catch (Exception)
            {
                StatusMessage = "Failed to update data";
            }
        }
    }
}
