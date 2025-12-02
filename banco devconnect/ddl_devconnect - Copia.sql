CREATE DATABASE db_devconnect;

USE db_devconnect;

CREATE TABLE tb_usuario(
id			INT				IDENTITY(1, 1)		PRIMARY KEY,
nome_completo	NVARCHAR(255)	NOT NULL,
nome_usuario	NVARCHAR(50)	UNIQUE				NOT NULL,
email			NVARCHAR(255)	UNIQUE				NOT NULL,
senha			NVARCHAR(50)	NOT NULL,
foto_perfil_url NVARCHAR(150)	NULL
);

SELECT * FROM tb_usuario;

CREATE TABLE tb_postagem(
id				INT				IDENTITY(1, 1)		PRIMARY KEY,
descricao		NVARCHAR(255)	NOT NULL,
imagem_url		NVARCHAR(150)	NULL,
data_postagem	DATE			NOT NULL,
);

SELECT * FROM tb_postagem;

ALTER TABLE tb_postagem
ADD id_usuario INT NOT NULL;


SELECT * FROM tb_postagem;

CREATE TABLE tb_curtida(
id_usuario		INT				NOT NULL,
id_postagem		INT				NOT NULL,

PRIMARY KEY(id_usuario, id_postagem)
);

ALTER TABLE tb_curtida
ADD COLUMN 

SELECT * FROM tb_curtida;

CREATE TABLE tb_comentario(
id				INT				IDENTITY(1, 1)		PRIMARY KEY,
texto			NVARCHAR(255)	NOT NULL,
data_comentario DATE			NOT NULL,
id_usuario		INT FOREIGN KEY REFERENCES tb_usuario(id),
id_postagem		INT FOREIGN KEY REFERENCES tb_postagem(id)
);

SELECT * FROM tb_comentario;

CREATE TABLE tb_seguidor(
id_usuario_seguir	INT			NOT NULL,
id_usuario_seguido  INT			NOT NULL,

PRIMARY KEY (id_usuario_seguir, id_usuario_seguido)
);

SELECT * FROM tb_seguidor;


