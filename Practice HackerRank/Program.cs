using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {



            //************ Counting Valley *****************//

            //int NoOfValley = 0;
            //string s = "UDDDUDUUDDUDUU";

            //int StepLevel = 0;

            //foreach (char item in s)
            //{
            //    if (StepLevel == 0 & item == 'D')
            //    {
            //        NoOfValley++;
            //        StepLevel--;
            //        continue;
            //    }

            //    if (item == 'U')
            //        StepLevel++;
            //    else
            //        StepLevel--;          
            //}

            //Console.WriteLine(NoOfValley);









            //************ Cloud Jumping *****************//

            //int[] arr = new int[] { 0, 0, 0, 1, 0,1, 0 };
            //int NoOfJumps = -1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i < arr.Length - 2 && arr[i + 2] == 0)
            //        i++;

            //    NoOfJumps++;
            //}
            //Console.WriteLine(NoOfJumps); 









            //************ Cloud Jumping *****************//
            //string str = "aba";
            //long n = 10;

            //long count = str.Length - str.Replace("a","").Length;

            //long div = n / str.Length;
            //long reminder = n % str.Length;

            //count = div * count;

            //for (int i = 0; i < reminder; i++)
            //{
            //    if (str.ElementAt(i) == 'a')
            //        count++;
            //}

            //return count;









            //************ Hour Glass *****************//


            //int[,] arr = new int[6, 6]{
            //    { -9, -9, -9,  1, 1, 1},
            //    { 0 ,-9,  0,  4, 3, 2 },
            //    { -9 ,-9 ,-9  ,1 ,2 ,3},
            //    { 0,  0,  8,  6, 6, 0 },
            //    { 0 , 0,  0, -2 ,0, 0 },
            //    { 0 , 0,  1,  2, 4, 0 }
            //};

            //int maxSum = -63;

            //for (int row = 0; row < arr.GetLength(0) -2 ; row++)
            //{
            //    for (int col = 0; col < arr.GetLength(1) -2 ; col++)
            //    {
            //       int  sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
            //                                arr[row + 1, col + 1] + 
            //            arr[row + 2, col] + arr[row + 2, col + 1] + arr[row+2, col + 2];
            //        maxSum = Math.Max(maxSum, sum);
            //    }
            //}

            //Console.WriteLine(maxSum);










            //************ Array Rotation *****************//



            /* Solution 1 ************************************************************/

            //string str = string.Join(" ", a);

            //for (int i = 0; i < d; i++)
            //{
            //    str += ' ';
            //    str += a[i].ToString();
            //    str = str.Substring(str.IndexOf(" ") + 1);
            //}

            //int[] newArray = str.Split(' ').Select(int.Parse).ToArray();
            //return newArray;


            /* Solution 2 ************************************************************/

            //int d = 4;

            //int[] a = new int[] { 1, 2, 3, 4, 5 };
            //int[] rotatedArr = new int[a.Length];

            //for (int i = 0; i < d; i++)
            //    rotatedArr[(a.Length - d) + i ] = a[i];             


            //for (int j = d; j < a.Length; j++)
            //    rotatedArr[j-d] = a[j];

            //foreach (int item in rotatedArr)
            //{
            //    Console.Write(item+" ");
            //}





            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //int swapCount = 0;

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{

            //    if (arr[i] != i + 1)
            //    { // filter cases, when you do not bribe, be at the ith position wherever you are

            //        if (((i - 1) >= 0) && arr[i - 1] == (i + 1))
            //        { // 1)Being at initial ith position, valid current
            //          // position after given bribe can be (i-1)th position
            //            swapCount++;
            //            swap(arr, i, i - 1);
            //        }
            //        else if (((i - 2) >= 0) && arr[i - 2] == (i + 1))
            //        { // 2)Being at initial ith position, valid current
            //          // position after given bribes can be (i-2)th
            //          // position
            //            swapCount += 2;
            //            swap(arr, i - 2, i - 1);
            //            swap(arr, i - 1, i);
            //        }
            //        else
            //        { // 3)Too chaotic (trying to bribe more than 2 people which is ahead of you)
            //            Console.WriteLine("Too chaotic");
            //            return;
            //        }
            //    }
            //}



            //static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
            //{
            //    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            //    SinglyLinkedListNode currentNode = head;

            //    int index = 0;
            //    while (index < position - 1)
            //    {
            //        currentNode = currentNode.next;
            //        index++;
            //    }

            //    newNode.next = currentNode.next;
            //    currentNode.next = newNode;

            //    return head;
            //}




            //static SinglyLinkedListNode reverse(SinglyLinkedListNode head)
            //{
            //    if (head == null) return head;

            //    SinglyLinkedListNode prev = null; // 5 -> 4 -> 3 -> 2 -> 1 -> NULL 
            //    SinglyLinkedListNode currrentNode = head;

            //    while (currrentNode != null)
            //    {

            //        SinglyLinkedListNode nextNode = currrentNode.next;
            //        currrentNode.next = prev;
            //        prev = currrentNode;
            //        currrentNode = nextNode;
            //    }
            //    return prev;








            //************ Detect a cycle in a linked list.Note  *****************//
            //that the head pointer may be 'NULL' if the list is empty.

            //************floyd's tortoise and hare Alogo ************//


            //bool has_cycle(Node* head)
            //{
            //    if (head == NULL) return false;

            //    Node* slow = head;
            //    Node* fast = head;

            //    while (fast != NULL && fast->next != NULL)
            //    {
            //        slow = slow->next;
            //        fast = fast->next->next;

            //        if (slow == fast)
            //            return true;
            //    }

            //    return false;
            //}








            //************ Minimum Swap 2 Array *****************//


            //    int[] arr = new int[] { 4, 3, 1, 2 };
            //    int noOfSwap = 0;
            //    int n = arr.Length - 1;

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (i < arr[i]-1)
            //        {
            //            Swap(arr, i, Math.Min(n, arr[i] - 1));
            //            noOfSwap++;
            //            i--;
            //        }
            //    }

            //    Console.WriteLine(noOfSwap);
            //}

            //static void Swap(int[] arr, int i, int j)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[j];
            //    arr[j] = temp;
            //}









            //************ Merge point of two linked list  *****************//



            //static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
            //{
            //    SinglyLinkedListNode Head1_Current = head1;
            //    SinglyLinkedListNode Head2_Current = head2;

            //    while (Head1_Current != Head2_Current)
            //    {
            //        if (Head1_Current.next == null)
            //        {
            //            Head1_Current = head2;
            //        }
            //        else
            //        {
            //            Head1_Current = Head1_Current.next;
            //        }

            //        if (Head2_Current.next == null)
            //        {
            //            Head2_Current = head1;
            //        }
            //        else
            //        {
            //            Head2_Current = Head2_Current.next;
            //        }
            //    }
            //    return Head2_Current.data;
            //}






            //static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
            //{
            //    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            //    if (llist == null) return newNode;

            //    newNode.next = llist;
            //    return newNode;
            //}





            //static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
            //{
            //    if (head == null) return head;
            //    if (position == 0) return head.next;

            //    int counter = 0;

            //    SinglyLinkedListNode currentNode = head;

            //    while (counter < position - 1)
            //    {
            //        currentNode = currentNode.next;
            //        counter++;
            //    }

            //    currentNode.next = currentNode.next.next;

            //    return head;
            //}


        }
    }
}
