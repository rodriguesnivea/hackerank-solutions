# Implementa��o da Fun��o `insertNodeAtHead`

## Introdu��o

Este documento descreve a implementa��o da fun��o `insertNodeAtHead`, que insere um novo n� no in�cio de uma lista ligada individualmente (singly linked list). A fun��o � escrita em C# e faz parte de uma estrutura de dados b�sica usada em v�rias aplica��es de ci�ncia da computa��o e programa��o.

## Descri��o da Fun��o

### Assinatura da Fun��o

```csharp
static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
```

### Par�metros

- `llist`: Um objeto do tipo `SinglyLinkedListNode` que representa a cabe�a (head) da lista ligada atual.
- `data`: Um valor inteiro (`int`) que ser� armazenado no novo n� a ser inserido na lista.

### Retorno

A fun��o retorna um objeto do tipo `SinglyLinkedListNode`, que representa a nova cabe�a da lista ap�s a inser��o do novo n�.

## Implementa��o

A fun��o `insertNodeAtHead` � respons�vel por adicionar um novo n� no in�cio de uma lista ligada individualmente. Aqui est� o c�digo da fun��o:

```csharp
static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
{
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    newNode.next = llist;

    return newNode;
}
```

### Explica��o do C�digo

1. **Cria��o de um Novo N�**: A fun��o come�a criando um novo n� com o valor fornecido (`data`). Isso � feito utilizando o construtor da classe `SinglyLinkedListNode`.

    ```csharp
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    ```

2. **Atualiza��o do Pr�ximo N�**: O campo `next` do novo n� � atualizado para apontar para o n� atual da cabe�a da lista (`llist`). Isso liga o novo n� ao in�cio da lista existente.

    ```csharp
    newNode.next = llist;
    ```

3. **Retorno da Nova Cabe�a**: Finalmente, a fun��o retorna o novo n�, que agora � a cabe�a da lista ligada.

    ```csharp
    return newNode;
    ```

### Estrutura da Classe `SinglyLinkedListNode`

Para que a fun��o `insertNodeAtHead` funcione corretamente, a classe `SinglyLinkedListNode` deve estar definida. Aqui est� um exemplo b�sico dessa classe:

```csharp
public class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}
```

## Conclus�o

A fun��o `insertNodeAtHead` � uma implementa��o simples e eficiente para inserir um n� no in�cio de uma lista ligada individualmente. Ela cria um novo n�, atualiza as refer�ncias para manter a estrutura da lista e retorna a nova cabe�a da lista. Esta fun��o � �til em v�rias opera��es de manipula��o de listas ligadas e pode ser utilizada em diversos contextos de programa��o.