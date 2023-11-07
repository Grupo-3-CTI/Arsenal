CREATE TABLE tbl_projetil (
    id_projetil SERIAL PRIMARY KEY,
    calibre VARCHAR(45) NOT NULL,
    projetil VARCHAR(45) NOT NULL,
    velocidade INT NOT NULL,
    peso INT NOT NULL,
    energia INT NOT NULL
);

CREATE TABLE tbl_arma (
    id_arma SERIAL PRIMARY KEY,
    numero_serie VARCHAR(45) NOT NULL,
    nome VARCHAR(45) NOT NULL,
    cadencia INT NOT NULL,
    data_fabricacao timestamp NOT NULL,
    projeteisporcartucho INT NOT NULL,
    projetil INT NOT NULL,
    FOREIGN KEY (projetil) REFERENCES tbl_projetil(id_projetil)
);