namespace Services;

using Context;
using Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class LibrosServices
{
    private readonly Contexto _context;
    public LibrosServices(Contexto contexto)
    {
        _context = contexto;
    }
    public async Task<bool> Guardar (Libros libros)
    {
        if(!await Existe(libros.Titulo))
        {
            return await Insertar(libros);
        }
        else
        {
            return await Modificar(libros);
        }
    }

    public async Task<bool> Insertar(Libros libro)
    {
        _context.libros.Add(libro);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(Libros libros)
    {
        _context.Update(libros);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Existe(string Titulo)
    {
        return await _context.libros
            .AnyAsync(l => l.Titulo == Titulo);
        
    }

    public async Task<Libros> Buscar(int id)
    {
        return await _context.libros.AsNoTracking().FirstOrDefaultAsync(l => l.LibroID == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var libro = await _context.libros.
            Where(l => l.LibroID == id).ExecuteDeleteAsync();
        return libro > 0;
    }

    public List<Libros> Listar (Expression<Func<Libros, bool >> criterio)
    {
        return _context.libros.
            AsNoTracking().
            Where(criterio).
            ToList();
    }
}