using tree_start;

public class MinHeap
{
    public Node Root { get; private set; }

    public MinHeap()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value)
    {
        // TODO 
        // Finish the insert function that calls itsel recursively
    }

    public void Traverse()
    {
        Traverse_forward(Root);
    }

    private void Traverse_forward(Node root)
    {
        // TODO
        // Finish the traverse_forward function (recursively)
    }

    public int RemoveMin()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("Heap is empty");
        }

        int minValue = Root.Data;
        Root = DeleteNode(Root, minValue);
        return minValue;
    }

    private Node DeleteNode(Node root, int value)
    {
        // TODO
        // Finish the DeleteNode function that removes the min value (recursively)
    }

    private int MinValue(Node node)
    {
        int minValue = node.Data;
        while (node.Left != null)
        {
            minValue = node.Left.Data;
            node = node.Left;
        }
        return minValue;
    }
}
