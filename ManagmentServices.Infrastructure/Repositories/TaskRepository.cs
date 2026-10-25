
using ManagmentServices.Application.Interfaces;
using ManagmentServices.Domain.Entities;
using ManagmentServices.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ManagmentServices.Infrastructure.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ApplicationDBContext _context;

    public TaskRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<List<TaskItem>> GetAllAsync()
    {
        return await _context.TaskItems.ToListAsync();
    }

    public async Task<TaskItem?> GetByIdAsync(int id)
    {
        return await _context.TaskItems.FindAsync(id);
    }

    public async Task<TaskItem> CreateAsync(TaskItem task)
    {
        await _context.TaskItems.AddAsync(task);
        await _context.SaveChangesAsync();

        return task;
    }

    public async Task UpdateAsync(TaskItem task)
    {
        _context.TaskItems.Update(task);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TaskItem task)
    {
        _context.TaskItems.Remove(task);
        await _context.SaveChangesAsync();
    }
}
