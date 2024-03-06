﻿using EleicaoCipa.Data.Repository.Interface;
using EleicaoCipa.Model;

namespace EleicaoCipa.Data.Repository;

public class CandidatoRepository : ICandidatoRepository
{
    private EleicaoContext _context;

    public CandidatoRepository(EleicaoContext context)
    {

        _context = context;
    }

    public Candidato Post(Candidato candidato)
    {
        _context.Candidatos.Add(candidato);
        _context.SaveChanges();
        return candidato;
    }

    public IEnumerable<Candidato> GetAll()
    {
        return _context.Candidatos.ToList();
    }

    public Candidato? GetById(int id)
    {
        return _context.Candidatos.FirstOrDefault(candidato => candidato.Id == id);
    }

    public Candidato Update(Candidato candidato)
    {
        _context.Update(candidato);
        _context.SaveChanges();
        return candidato;
    }
}