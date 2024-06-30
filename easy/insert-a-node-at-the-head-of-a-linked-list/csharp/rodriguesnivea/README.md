# Implementação da Função `insertNodeAtHead`

## Introdução

Este documento descreve a implementação da função `insertNodeAtHead`, que insere um novo nó no início de uma lista ligada individualmente (singly linked list). A função é escrita em C# e faz parte de uma estrutura de dados básica usada em várias aplicações de ciência da computação e programação.

## Descrição da Função

### Assinatura da Função

```csharp
static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
```

### Parâmetros

- `llist`: Um objeto do tipo `SinglyLinkedListNode` que representa a cabeça (head) da lista ligada atual.
- `data`: Um valor inteiro (`int`) que será armazenado no novo nó a ser inserido na lista.

### Retorno

A função retorna um objeto do tipo `SinglyLinkedListNode`, que representa a nova cabeça da lista após a inserção do novo nó.

## Implementação

A função `insertNodeAtHead` é responsável por adicionar um novo nó no início de uma lista ligada individualmente. Aqui está o código da função:

```csharp
static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
{
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    newNode.next = llist;

    return newNode;
}
```

### Explicação do Código

1. **Criação de um Novo Nó**: A função começa criando um novo nó com o valor fornecido (`data`). Isso é feito utilizando o construtor da classe `SinglyLinkedListNode`.

    ```csharp
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    ```

2. **Atualização do Próximo Nó**: O campo `next` do novo nó é atualizado para apontar para o nó atual da cabeça da lista (`llist`). Isso liga o novo nó ao início da lista existente.

    ```csharp
    newNode.next = llist;
    ```

3. **Retorno da Nova Cabeça**: Finalmente, a função retorna o novo nó, que agora é a cabeça da lista ligada.

    ```csharp
    return newNode;
    ```

### Estrutura da Classe `SinglyLinkedListNode`

Para que a função `insertNodeAtHead` funcione corretamente, a classe `SinglyLinkedListNode` deve estar definida. Aqui está um exemplo básico dessa classe:

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

A função `insertNodeAtHead` é uma implementação simples e eficiente para inserir um nó no início de uma lista ligada individualmente. Ela cria um novo nó, atualiza as referências para manter a estrutura da lista e retorna a nova cabeça da lista. Esta função é útil em várias operações de manipulação de listas ligadas e pode ser utilizada em diversos contextos de programação.