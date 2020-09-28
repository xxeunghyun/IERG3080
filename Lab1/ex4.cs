/*
terminate at three conditions
1) two consecutive 0s
2) meets -1
3) else, terminate after go through elements
*/

static void PrintArray(int[] a)
        {
           
            int i;

            for (i = 0; i < 10; i++)
            {
                // Console.WriteLine(a[i]);

                if (a[i] == -1)
                {
                    break;

                }

                else if (a[i] == 0 && a[i + 1] == 0)
                {
                    Console.Write("{0} ", a[i]);
                    break;
                }

                else
                {
                    Console.Write("{0} ", a[i]);
                   
                }

            }
            
        }

