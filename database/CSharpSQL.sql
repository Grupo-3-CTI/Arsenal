CREATE TABLE tbl_projetil (
    id SERIAL PRIMARY KEY,
    calibre VARCHAR(255) NOT NULL,
    nome VARCHAR(255) NOT NULL,
    velocidade INT NOT NULL,
    peso INT NOT NULL,
    energia numeric(16,2) NOT NULL
);

CREATE TABLE tbl_arma (
    id SERIAL PRIMARY KEY,
    numero_serie VARCHAR(255) NOT NULL,
    nome VARCHAR(255) NOT NULL,
    cadencia INT NOT NULL,
    data_fabricacao date NOT NULL,
    projeteisporcartucho INT NOT NULL,
    projetil INT NOT NULL,
    FOREIGN KEY (projetil) REFERENCES tbl_projetil(id)
);
