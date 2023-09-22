# Especificação de APIs

| Endpoint   | Método | Descrição                                       | Parâmetros                                   | Formato da Resposta | Autenticação e Autorização |
|--------------------------------------|--------|------------------------------------------------|-----------------------------------|---------------------|----------------------------|
| /api/posts/{post_id} | GET    | Recupera a lista de todas as postagens no blog. | Nenhum.                                      | JSON                | Não é necessária autenticação para acessar postagens públicas. |
| /api/posts | GET     | Recupera uma postagem específica pelo ID.       | {post_id} - ID da postagem a ser recuperada. | JSON                | Não é necessária autenticação para acessar postagens públicas. |
| /api/posts/{post_id} | POST   | Cria uma nova postagem no blog.                 | Nenhum. | JSON                               | JSON                | Requer autenticação de um usuário autorizado. |
| /api/posts/{post_id} | PUT    | Atualiza uma postagem existente pelo ID.        | {post_id} - ID da postagem a ser atualizada. | JSON                | Requer autenticação de um usuário autorizado. |
| /api/comments        | DELETE | Exclui uma postagem existente pelo ID.          | {post_id} - ID da postagem a ser excluída.   | JSON                | Requer autenticação de um usuário autorizado. |

[Retorna](../README.md)
