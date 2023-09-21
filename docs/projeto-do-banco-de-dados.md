# Projeto do Banco de Dados

![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e4-proj-dist-t1-blog-pessoal/assets/75402234/63893b65-138a-4606-9938-785f94a655a1)

  A tabela "Posts" armazena informações sobre cada post, incluindo um ID exclusivo, título, conteúdo, ID do autor, data de publicação e uma opção para uma imagem ilustrativa (opcional).
  A tabela "Autores" armazena informações sobre os autores, incluindo um ID exclusivo, nome e função (Ex: "Confeiteiro", "Especialista em Moda", "Influencer de Games").
  Cada post na tabela "Posts" está associado a um autor por meio do campo "Autor_ID", que é uma chave estrangeira que referencia o ID do autor na tabela "Autores". Isso permite que os posts sejam atribuídos a um autor específico.
