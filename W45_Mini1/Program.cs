using W45_Mini1;

Console.WriteLine("Asset Tracking for Company!");

/*  
 *  --------------------------------------------
 *  ---              Level 1                 ---
 *  --------------------------------------------
*/

//Creation of objects within the different asset classes, simulating the 'database'
Computer pc1 = new Computer("Computer", "Lenovo", "Ideacentre", 1530, new DateTime(2020, 03, 20));
Computer pc2 = new Computer("Computer", "Acer", "Aspire XC", 1550, new DateTime(2019, 12, 29));
Computer pc3 = new Computer("Computer", "Lenovo", "Legion", 1600, new DateTime(2021, 10, 04));
Computer pc4 = new Computer("Computer", "HP", "Z2 Tower", 1490, new DateTime(2022, 02, 28));

Laptop laptop1 = new Laptop("Laptop", "Apple", "MacBook", 650, new DateTime(2021, 05, 03));
Laptop laptop2 = new Laptop("Laptop", "Lenovo", "ThinkPad X1", 580, new DateTime(2022, 11, 27));
Laptop laptop3 = new Laptop("Laptop", "Samsung", "Galaxy", 550, new DateTime(2020, 09, 18));

Phone phone1 = new Phone("Phone", "Apple", "iPhone 10", 230, new DateTime(2021, 04, 25));
Phone phone2 = new Phone("Phone", "Samsung", "S21", 200, new DateTime(2022, 07, 07));
Phone phone3 = new Phone("Phone", "Samsung", "S20", 180, new DateTime(2022, 01, 13));
Phone phone4 = new Phone("Phone", "Huawei", "P30 Pro", 150, new DateTime(2020, 12, 27));
Phone phone5 = new Phone("Phone", "Apple", "iPhone 10", 250, new DateTime(2021, 10, 30));


/*  
 *  --------------------------------------------
 *  ---              Level 2                 ---
 *  --------------------------------------------
*/

List<Hardware> assets = new List<Hardware>();

// adding initial assets to list
assets.Add(laptop1);
assets.Add(laptop2);
assets.Add(laptop3);
assets.Add(pc1);
assets.Add(pc2);
assets.Add(pc3);
assets.Add(pc4);
assets.Add(phone1);
assets.Add(phone2);
assets.Add(phone3);
assets.Add(phone4);
assets.Add(phone5);

List<Hardware> orderedAssets = assets.OrderBy(h => h.Type).ThenBy(x => x.DateOfPurchase).ToList();

Console.WriteLine("Type".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Price (USD)".PadRight(20) + "Date of purchase");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
foreach (Hardware hardware in orderedAssets)
{
    Console.WriteLine(hardware.Type.PadRight(20) + hardware.Brand.PadRight(20) + hardware.Model.PadRight(20) + hardware.Price.ToString().PadRight(20) + hardware.DateOfPurchase.ToString("yyyy-MM-dd"));
}