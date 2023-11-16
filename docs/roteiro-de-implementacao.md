# Código do projeto

https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/tree/main/docs/codigo

# Documentação API

```

openapi: 3.0.0
info:
  title: API BlogPessoal
  version: 1.0.0
  description: Uma API para criar, editar e excluir postagens em um blog.

paths:
  /postagens:
    get:
      summary: Lista todas as postagens
      responses:
        '200':
          description: Sucesso
          content:
            application/json:
              example:
                - id: 1
                  titulo: "Minha Primeira Postagem"
                  conteudo: "Conteúdo da postagem aqui"
                - id: 2
                  titulo: "Outra Postagem"
                  conteudo: "Conteúdo da outra postagem"

    post:
      summary: Cria uma nova postagem
      requestBody:
        required: true
        content:
          application/json:
            example:
              titulo: "Nova Postagem"
              conteudo: "Conteúdo da nova postagem"
      responses:
        '201':
          description: Postagem criada com sucesso
        '400':
          description: Erro nos dados de entrada

  /postagens/{id}:
    get:
      summary: Obtém detalhes de uma postagem específica
      parameters:
        - name: id
          in: path
          required: true
          description: ID da postagem
          schema:
            type: integer
      responses:
        '200':
          description: Sucesso
          content:
            application/json:
              example:
                id: 1
                titulo: "Minha Primeira Postagem"
                conteudo: "Conteúdo da postagem aqui"
        '404':
          description: Postagem não encontrada

    put:
      summary: Edita uma postagem existente
      parameters:
        - name: id
          in: path
          required: true
          description: ID da postagem
          schema:
            type: integer
      requestBody:
        required: true
        content:
          application/json:
            example:
              titulo: "Postagem Atualizada"
              conteudo: "Conteúdo atualizado da postagem"
      responses:
        '200':
          description: Postagem editada com sucesso
        '400':
          description: Erro nos dados de entrada
        '404':
          description: Postagem não encontrada

    delete:
      summary: Exclui uma postagem
      parameters:
        - name: id
          in: path
          required: true
          description: ID da postagem
          schema:
            type: integer
      responses:
        '204':
          description: Postagem excluída com sucesso
        '404':
          description: Postagem não encontrada
```

# Testes

# Adição de nova Postagem

## Tela de Postagens:

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/cec8d5a8-a68c-4659-b24a-248fa3e0d7fc)
![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/bc6d03fa-ca6c-4994-bb25-8c0176e02f3c)

## Tela de adição de Postagem:

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/480cb015-f7d0-449b-8e21-398ad86b5b1e)

## Item Adicionado:

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/60be1ba3-816c-4d96-900e-3ed75fbbaefc)
![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/2d3d82ff-ef7e-40af-a962-83b279d71e6b)

# Edição da Postagem

## Tela de edição de Postagem:

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/ded4200a-e7ba-4ffb-ad5a-af7069a237cc)

## Postagem alterada:

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/8cea4999-71d0-4ff5-8372-6979e7d97592)
![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/b3b30d0c-44b8-4518-bacb-57336d7ddd97)

# Exclusão da Postagem:

## Tela de exclusão de Postagem

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/cc9ee047-b370-4a53-aab6-3237e2f959cb)

## Postagem deletada:

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/d247c45d-c768-4013-b4b2-da665fc76d9c)
![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/0ff6a5bd-0609-4e9c-b75f-721c0da773d1)


