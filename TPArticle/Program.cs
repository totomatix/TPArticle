using TPArticle;

// Création d'un article avec le constructeur par défaut
Article A1 = new Article();
A1.Reference = "A0001";
A1.Designation = "Article 1";
A1.PrixHT = 100;
A1.AfficherArticle();

// Création d'un article avec le constructeur permettant de spécifier la désignation et la référence
Article A2 = new Article("A0002", "Article 2");
A2.PrixHT = 35;
A2.AfficherArticle();

// Création d'un article avec le constructeur complet
Article A3 = new Article("A0003", "Article 3",400);
A3.AfficherArticle();

// création d'un article en utilisant le constructeur par copie
Article A4 = new Article(A1);
A4.AfficherArticle();