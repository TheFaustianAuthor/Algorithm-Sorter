public class SelectionSort : ISortAlgorithm //creates the class and names it ISortAlgorithm. 
{
    public string Name => "Selection Sort"; //gives the public name of the algorithm selection sort so if any .name appears it comes up selection sort.

    public void Sort(int[] array, Action<int>[] onStep)
    //does the work, void means it will not return anything after it is done. 
    //int[] array is the numbers that will be sorted.
    //action<int> onstep is the callback so it will call everytime the array is changed.
    {
        for (int i = 0; i < array.Length - 1; i++)
        //outer loop where i is the index.
        //i starts at 0 i++ adds 1 value so i walks through all the positions, and will move 1 behind the last value going back and forward looping.

        {
            
        

         int smallestIndex = i; //holds the smallest position

         for (int j = i + 1; j < array.Length; j++)//the inner loop where it starts after i as there is no point to compare i to itself.
                //its meant to loop the unsorted regions.
            {
                if (array[j] < array[smallestIndex]) // j checks if the value is smaller then the smaller value and move it to the start.
                {
                    smallestIndex = j; //if it finds something it will make it the smallest index. and set it as the new position.
                }
            }

            int temp = array[i]; //stores the value of i
            array[i] = array[smallestIndex]; // copies the smallest value to the position.
            array[smallestIndex] = temp; //swap places with the smallest value and the current value

            onStep?.Invoke(array); //helps prevent crash for the visualizer.
        }
    }
   
}