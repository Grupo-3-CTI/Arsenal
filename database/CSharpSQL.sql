CREATE TABLE tbl_projetil (
    id SERIAL PRIMARY KEY,
    calibre VARCHAR(45) NOT NULL,
    projetil VARCHAR(45) NOT NULL,
    velocidade INT NOT NULL,
    peso INT NOT NULL,
    energia numeric(10,2) NOT NULL
);

CREATE TABLE tbl_arma (
    id SERIAL PRIMARY KEY,
    numero_serie VARCHAR(45) NOT NULL,
    nome VARCHAR(45) NOT NULL,
    cadencia INT NOT NULL,
    data_fabricacao timestamp NOT NULL,
    projeteisporcartucho INT NOT NULL,
    projetil INT NOT NULL,
    FOREIGN KEY (projetil) REFERENCES tbl_projetil(id_projetil)
);