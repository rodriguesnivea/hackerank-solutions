class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
{
    var newNode = new SinglyLinkedListNode(data);
    if (llist == null || position == 0)
    {
        newNode.next = llist;
        return newNode;
    }

    SinglyLinkedListNode aux = llist;
    int count = 0;
    SinglyLinkedListNode anterior = llist;
    while (aux != null)
    {

        if (position == count)
        {
            anterior.next = newNode;
            newNode.next = aux;
            break;
        }
        anterior = aux;
        aux = aux.next;
        count++;
    }
    if (count == position)
        anterior.next = newNode;
    return llist;
}

}