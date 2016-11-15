public static int FindContentChildren(int[] g, int[] s)
        {
            int i = 0, j = 0, x =0;
            //Sorting both arrays
            Array.Sort(g);
            Array.Sort(s);

            //checking if i and j both are less then the Length of their respective arrays
            while(i<g.Length &&j<s.Length)
            {
                //If the greed level of child is greater than the current size of cookie. Move to next cookie i.e j++.
                if (g[i] > s[j])
                    j++;

                // If cookie size matches the greed of child then move to next cookie i.e j++ and next child i.e i++ more over
                // Increase the numbers of satisfied children i.e x++
                else
                {
                    x++; i++; j++;
                }
            }

            return x;
        }