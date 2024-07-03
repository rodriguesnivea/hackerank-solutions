# Implementa��o da Fun��o `insertNodeAtPosition`

## Introdu��o

Este documento descreve a implementa��o da fun��o `insertNodeAtPosition`, que insere um novo n� em uma posi��o espec�fica de uma lista ligada individualmente (singly linked list). A fun��o � escrita em C# e faz parte de uma estrutura de dados b�sica usada em v�rias aplica��es de ci�ncia da computa��o e programa��o.

## Descri��o da Fun��o

### Assinatura da Fun��o

```csharp
public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
```

### Par�metros

- `llist`: Um objeto do tipo `SinglyLinkedListNode` que representa a cabe�a (head) da lista ligada atual.
- `data`: Um valor inteiro (`int`) que ser� armazenado no novo n� a ser inserido na lista.
- `position`: Um valor inteiro (`int`) que indica a posi��o na qual o novo n� ser� inserido.

### Retorno

A fun��o retorna um objeto do tipo `SinglyLinkedListNode`, que representa a cabe�a da lista ap�s a inser��o do novo n�.

## Implementa��o

A fun��o `insertNodeAtPosition` � respons�vel por adicionar um novo n� em uma posi��o espec�fica de uma lista ligada individualmente. Aqui est� o c�digo da fun��o:

```csharp
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
```

### Explica��o do C�digo

1. **Cria��o de um Novo N�**: A fun��o come�a criando um novo n� com o valor fornecido (`data`). Isso � feito utilizando o construtor da classe `SinglyLinkedListNode`.

    ```csharp
    var newNode = new SinglyLinkedListNode(data);
    ```

2. **Inser��o no In�cio da Lista**: Se a lista est� vazia (`llist == null`) ou se a posi��o especificada � `0`, o novo n� se torna a cabe�a da lista.

    ```csharp
    if (llist == null || position == 0)
    {
        newNode.next = llist;
        return newNode;
    }
    ```

3. **Percorrendo a Lista**: A fun��o utiliza um loop para percorrer a lista at� encontrar a posi��o desejada. Durante o loop, dois ponteiros s�o usados: `aux` para o n� atual e `anterior` para o n� anterior ao atual.

    ```csharp
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
    ```

4. **Inser��o na Posi��o Espec�fica**: Quando a posi��o � encontrada, o novo n� � inserido. O ponteiro `next` do n� anterior � atualizado para apontar para o novo n�, e o ponteiro `next` do novo n� � atualizado para apontar para o n� atual.

    ```csharp
    if (count == position)
        anterior.next = newNode;
    ```

5. **Retorno da Nova Cabe�a**: Finalmente, a fun��o retorna a cabe�a da lista, que pode ser a mesma ou alterada se a inser��o foi no in�cio.

    ```csharp
    return llist;
    ```

### Estrutura da Classe `SinglyLinkedListNode`

Para que a fun��o `insertNodeAtPosition` funcione corretamente, a classe `SinglyLinkedListNode` deve estar definida. Aqui est� um exemplo b�sico dessa classe:

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

A fun��o `insertNodeAtPosition` � uma implementa��o flex�vel e eficiente para inserir um n� em uma posi��o espec�fica de uma lista ligada individualmente. Ela permite adicionar novos n�s em qualquer posi��o, atualizando as refer�ncias necess�rias para manter a estrutura da lista. Esta fun��o � �til em v�rias opera��es de manipula��o de listas ligadas e pode ser utilizada em diversos contextos de programa��o.