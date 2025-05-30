public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter each element: ");
        int[] arrays = new int[size];

        //Nhap phan tu
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arrays[i] = Convert.ToInt32(Console.ReadLine());
        }

        //In mang ra man hinh
        foreach (var item in arrays)
        {
            Console.WriteLine(item + "\t");
        }

        //khai bao bien
        Console.Write("Insert an element: ");
        int insertElement = Convert.ToInt32(Console.ReadLine());
        Console.Write("Position to insert: ");
        int position = Convert.ToInt32(Console.ReadLine());

        //
        if (position < 0 || position > arrays.Length)
        {
            Console.WriteLine("Failed to insert the element into the array.");
        }
        else
        {
            //tao lai mang nua dau
            int[] newArrays = new int[size + 1];
            for (int i = 0; i < position; i++)
            {
                newArrays[i] = arrays[i];
            }
            newArrays[position] = insertElement;
            
            //nua mang sau
            for (int i = position; i < arrays.Length; i++)
            {
                newArrays[i + 1] = arrays[i];
            }

            //in mang moi
            foreach (int item in newArrays)
            {
                Console.Write(item + "/t");
            }
        }     
    }
}