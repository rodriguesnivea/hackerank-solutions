# Implementação da Função `insertNodeAtPosition`

## Introdução

Este documento descreve a implementação da função `insertNodeAtPosition`, que insere um novo nó em uma posição específica de uma lista ligada individualmente (singly linked list). A função é escrita em C# e faz parte de uma estrutura de dados básica usada em várias aplicações de ciência da computação e programação.

## Descrição da Função

### Assinatura da Função

```csharp
public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
```

### Parâmetros

- `llist`: Um objeto do tipo `SinglyLinkedListNode` que representa a cabeça (head) da lista ligada atual.
- `data`: Um valor inteiro (`int`) que será armazenado no novo nó a ser inserido na lista.
- `position`: Um valor inteiro (`int`) que indica a posição na qual o novo nó será inserido.

### Retorno

A função retorna um objeto do tipo `SinglyLinkedListNode`, que representa a cabeça da lista após a inserção do novo nó.

## Implementação

A função `insertNodeAtPosition` é responsável por adicionar um novo nó em uma posição específica de uma lista ligada individualmente. Aqui está o código da função:

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

### Explicação do Código

1. **Criação de um Novo Nó**: A função começa criando um novo nó com o valor fornecido (`data`). Isso é feito utilizando o construtor da classe `SinglyLinkedListNode`.

    ```csharp
    var newNode = new SinglyLinkedListNode(data);
    ```

2. **Inserção no Início da Lista**: Se a lista está vazia (`llist == null`) ou se a posição especificada é `0`, o novo nó se torna a cabeça da lista.

    ```csharp
    if (llist == null || position == 0)
    {
        newNode.next = llist;
        return newNode;
    }
    ```

3. **Percorrendo a Lista**: A função utiliza um loop para percorrer a lista até encontrar a posição desejada. Durante o loop, dois ponteiros são usados: `aux` para o nó atual e `anterior` para o nó anterior ao atual.

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

4. **Inserção na Posição Específica**: Quando a posição é encontrada, o novo nó é inserido. O ponteiro `next` do nó anterior é atualizado para apontar para o novo nó, e o ponteiro `next` do novo nó é atualizado para apontar para o nó atual.

    ```csharp
    if (count == position)
        anterior.next = newNode;
    ```

5. **Retorno da Nova Cabeça**: Finalmente, a função retorna a cabeça da lista, que pode ser a mesma ou alterada se a inserção foi no início.

    ```csharp
    return llist;
    ```

### Estrutura da Classe `SinglyLinkedListNode`

Para que a função `insertNodeAtPosition` funcione corretamente, a classe `SinglyLinkedListNode` deve estar definida. Aqui está um exemplo básico dessa classe:

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

## Conclusão

A função `insertNodeAtPosition` é uma implementação flexível e eficiente para inserir um nó em uma posição específica de uma lista ligada individualmente. Ela permite adicionar novos nós em qualquer posição, atualizando as referências necessárias para manter a estrutura da lista. Esta função é útil em várias operações de manipulação de listas ligadas e pode ser utilizada em diversos contextos de programação.