use MyDatabase;
show tables;

create table companies(name char(15),contry char(20));

create table trades(id int, seller char(15), buyer char(15), value int);

show tables;
describe companies;

drop table companies;

select * from companies;
select * from trades;

INSERT INTO companies (name, contry)
VALUES ('Alice s.p.', 'Wonderland'), 
('Y-zap', 'Wonderland'), 
('Absolute', 'Mathlands'), 
('Arcus t.g.', 'Mathlands'), 
('Lil Mermaid', 'Underwater Kingdom'), 
('Not at all', 'Nothingland');

INSERT INTO trades (id, seller, buyer, value)
VALUES (20121107, 'Lil Mermaid', 'Alice s.p.', 10), 
(20123112, 'Arcus t.g.', 'Y-zap', 30), 
(20120125, 'Alice s.p.', 'Arcus t.g.', 100), 
(20120216, 'Lil Mermaid', 'Absolute', 30), 
(20120217, 'Lil Mermaid', 'Absolute', 50);