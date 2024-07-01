using Web_api.Models;

namespace Web_api.Data
{
    public class SeedData
    {
        public static void Initialize(DataContext db)
        {
            var CD = new Device[]{
                new Device {
                    id = 1,
                    userId = "78275198-9bba-4c38-97b0-b5e5fd5d6b44",
                    title = "um",
                    status = "fechado",
                    wifi = "s"
                },
                new Device {
                    id = 2,
                    userId = "78275198-9bba-4c38-97b0-b5e5fd5d6b44",
                    title = "dois",
                    status = "fechado",
                    wifi = "n"
                },
                new Device {
                    id = 3,
                    userId = "78275198-9bba-4c38-97b0-b5e5fd5d6b44",
                    title = "tres",
                    status = "fechado",
                    wifi = "n"
                },
                new Device {
                    id = 4,
                    userId = "78275198-9bba-4c38-97b0-b5e5fd5d6b44",
                    title = "quatro",
                    status = "fechado",
                    wifi = "s"
                }
            };
            db.cd.AddRange(CD);
            db.SaveChanges();
        }
    }
}
