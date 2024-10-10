Episodio ep1 = new(2, "Tecnicas de Facilitacao", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Arthur");

Episodio ep2 = new(1, "Tecnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Marina");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();