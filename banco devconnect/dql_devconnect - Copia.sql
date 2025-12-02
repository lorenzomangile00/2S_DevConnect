USE db_devconnect;

SELECT nome_completo, nome_usuario, email
FROM tb_usuario
WHERE nome_completo = 'Veiga Nata SP';

SELECT nome_completo, nome_usuario, email
FROM tb_usuario
WHERE nome_completo = 'Gomez Capitao';

SELECT data_comentario
FROM tb_comentario
WHERE texto = 'Raphael Craque Veiga ta voltando em';

SELECT MAX(texto) AS comentario_recente FROM tb_comentario
GROUP BY texto, data_comentario
ORDER BY comentario_recente DESC; 

SELECT COUNT(nome_usuario) AS qtd_usuarios FROM tb_usuario;

SELECT SUM(id) FROM tb_usuario;

SELECT MIN(email) AS email_do_perfil FROM tb_usuario
GROUP BY email
ORDER BY email_do_perfil DESC;

---------------------------------------
--3
SELECT 
tb_postagem.descricao,
tb_postagem.imagem_url,
tb_usuario.nome_usuario
FROM tb_postagem 
JOIN tb_usuario ON tb_postagem.id_usuario = tb_usuario.id;

--6
SELECT 
tb_usuario.nome_usuario
FROM tb_usuario
LEFT JOIN tb_postagem ON tb_usuario.id = tb_postagem.id_usuario
WHERE tb_postagem.id IS NULL;

SELECT 
tb_usuario.nome_usuario, 
tb_postagem.id AS Postagens
FROM tb_postagem
RIGHT JOIN tb_usuario ON tb_postagem.id_usuario = tb_usuario.id
WHERE tb_postagem.id IS NULL;

--2
SELECT 
tb_usuario.nome_usuario,
COUNT(tb_seguidor.id_usuario_seguir) AS qtd_seguidores
FROM tb_seguidor 
INNER JOIN tb_usuario ON tb_seguidor.id_usuario_seguido = tb_usuario.id
GROUP BY tb_usuario.nome_usuario;


SELECT *
FROM 
tb_seguir.nome_completo
tb_seguido.nome_completo
INNER JOIN tb_usuario.id_usuario_seguir ON id_usuario_seguir = tb_seguidor.id_usuario_seguir
INNER JOIN tb_usuario.id_usuario_seguido ON id_usuario_seguido = tb_seguidor.id_usuario_seguido 

SELECT 
tb_usuario.nome_usuario
FROM tb_usuario 
LEFT JOIN tb_curtida ON tb_usuario.id_usuario = tb_curtida.id_usuario
LEFT JOIN tb_comentario cm ON u.id_usuario = cm.id_usuario
WHERE c.id_curtida IS NULL AND cm.id_comentario IS NULL;

--
SELECT 
tb_usuario.nome_usuario, 
tb_curtida.id_postagem AS Curtidas
FROM tb_curtida 
RIGHT JOIN tb_usuario ON tb_curtida.id_usuario = tb_usuario.id
WHERE tb_curtida.id_usuario IS NULL;

