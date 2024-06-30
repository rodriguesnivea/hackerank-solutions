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

static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
{
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    newNode.next = llist;

    return newNode;
}