public static int [] GetValueIndexes(this string str, char elements)
     {
      int[] AddItem = new int[0];

       for (int i = 0; i <AddItem.Length; i++)
            {
            if(AddItem[i]==elements)
            {
                    Array.Resize(ref AddItem, AddItem.Length + 1);
                    AddItem[AddItem.Length - 1] = item;
            }
            }
            return AddItem;
        }
