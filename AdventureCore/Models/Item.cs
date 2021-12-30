using AdventureCore.ViewModels.Models;

namespace AdventureCore.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }

        public override string ToString()
        {
            return $"{ItemID} - {ItemName}";
        }
    }
}
