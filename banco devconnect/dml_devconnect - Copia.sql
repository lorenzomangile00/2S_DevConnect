USE db_devconnect;

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES 
('Veiga Nata SP', 'magoveiga23', 'magnata00', 'raphaelveiga', 1 ),
('Gomez Capitao', 'gomezrlk', 'gustavogomez', 'gustavorlk', 1);

SELECT * FROM tb_usuario;

INSERT INTO tb_postagem (descricao, imagem_url, data_postagem, id_usuario)
VALUES
('Saudades quando eu sabia jogar kkkk', 1, '2025-10-02', 1),
('reclamam mas precisam do 01', 1, '2025-09-30', 1);

SELECT * FROM tb_postagem;



INSERT INTO tb_curtida(id_usuario, id_postagem)
VALUES (1, 1);

SELECT * FROM tb_curtida;

INSERT INTO tb_comentario(texto, data_comentario, id_usuario, id_postagem)
VALUES 
('Raphael Craque Veiga ta voltando em', '2025-10-02', 1, 3),
('Boa capitao, so os veterano', '2025-09-30', 1, 4);

SELECT * FROM tb_comentario;



SELECT * FROM tb_comentario;

INSERT INTO tb_seguidor(id_usuario_seguir, id_usuario_seguido)
VALUES (1, 1);

SELECT * FROM tb_seguidor;