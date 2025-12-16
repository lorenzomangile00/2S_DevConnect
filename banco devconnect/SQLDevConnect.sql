use db_devconnect;

--Alterar a coluna IdUsuario da tabela

ALTER TABLE tb_postagem
ALTER COLUMN id_usuario INT NULL;

ALTER TABLE tb_curtida
ADD UNIQUE(id_usuario, id_postagem)

--DROP TABLE tb_seguidor;

CREATE TABLE tb_seguidor(
id_usuario_seguir	INT			NOT NULL,
id_usuario_seguido  INT			NOT NULL,

PRIMARY KEY (id_usuario_seguir, id_usuario_seguido),
FOREIGN KEY (id_usuario_seguir) REFERENCES tb_usuario(id),
FOREIGN KEY (id_usuario_seguido) REFERENCES tb_usuario(id)
);

