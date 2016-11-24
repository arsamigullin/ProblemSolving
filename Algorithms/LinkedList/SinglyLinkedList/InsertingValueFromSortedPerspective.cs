using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Inserting values from sorted perspective", typeof(List<string>))]
    public class InsertingValueFromSortedPerspective
    {

        private ISinglyCell<int> initialCell= new SinglyCell<int>();
        List<int> listVel = new List<int>();

        public InsertingValueFromSortedPerspective()
        {
            initialCell.Value = 1;
            listVel.Add(6);
            listVel.Add(8);
            listVel.Add(18);
            listVel.Add(19);
            listVel.Add(23);
            listVel.Add(157);
            //filling linked list
            foreach (var i in listVel)
            {
                ISinglyCell<int> afterMe = initialCell;
                while (afterMe.Next != null)
                {
                    afterMe = afterMe.Next;
                }
                afterMe.Next= new SinglyCell<int>();
                afterMe.Next.Value = i;
            }
          
        }

        public List<string> Insert()
        {
            // new cell for inserting
            ISinglyCell<int> newCell = new SinglyCell<int>();
            newCell.Value = -3;
            ISinglyCell<int> cell = initialCell;
            while (cell != null)
            {
                if (cell.Value > newCell.Value)
                {
                    //In this case  finally linked list will be newCell
                    newCell.Next = cell;
                    break;
                }
                // if value of the new cell between two existing values
                if (cell.Value <= newCell.Value
                && (cell.Next == null || cell.Next.Value >= newCell.Value))
                {
                    // insert it
                    ISinglyCell<int> nextCell = cell.Next;
                    newCell.Next = nextCell;
                    cell.Next = newCell;
                    break;
                }
                cell = cell.Next;
            }

            return new List<string> {"DONE"};
        }
    }
}

