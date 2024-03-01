﻿using EleicaoCipa.Enums;

namespace EleicaoCipa.Model;

public class Eleicao
{
    public int Id { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public StatusEnum Status {  get; set; } 
}