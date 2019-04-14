using System;
using System.Collections;

namespace WpBlog.model{
    public class post{
        public int ID {get;set;}
        public string titulo {get; set;}
        public string conteudo {get;set;}
        public string descricao {get;set;}
       // public Usuario usuario {get;set;}
       // public List<string> labels{get;set;}
        public DateTime dataCriacao {get;set;}
        public DateTime dataEdicao {get;set;}
       // public Comentario comentario {get;set;}
        public bool Ativo { get; set; }


    }
}