namespace BJSSBasket.Items
{
    public static class ItemFactory
    {
        //takes user input and ruturns the items as usable objects
        public static IItem createItem(string itemtype)
        {
            switch (itemtype.Trim())
            {
                case "Apples":
                case "apples":
                    return new Apples();

                case "Bread":
                case "bread":
                    return new Bread();

                case "Milk":
                case "milk":
                    return new Milk();

                case "Soup":
                case "soup":
                    return new Soup();

                default:
                    throw new ArgumentException(itemtype);

            }

        }
    }
}
