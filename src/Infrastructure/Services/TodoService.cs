using Dummy.Application.DTOs;
using Dummy.Infrastructure.Interfaces;

namespace Dummy.Infrastructure.Services;

public class TodoService : ITodoService {

  #region Private Fields
  #endregion

  #region Constructors
  #endregion

  #region Crud Functionality
  public async Task<Response<TodoDTO>> AddAsync(TodoDTO todo) {
    throw new NotImplementedException();
  }

  public async Task<Response<int>> DeleteAsync(int id) {
    throw new NotImplementedException();
  }

  public async Task<Response<List<TodoDTO>>> GetAsync() {
    return new Response<List<TodoDTO>>() {
      Success = true,
      Message = "Items found",
      Data = [
        new TodoDTO() { Id=1, Title="Bring eggs from market", Description="lorem ipsum", IsCompleted = false },
        new TodoDTO() { Id=2, Title="Visit bank for ATM", Description="lorem ipsum", IsCompleted = false },
        new TodoDTO() { Id=3, Title="Visit dentist this week", Description="lorem ipsum", IsCompleted = true },
        new TodoDTO() { Id=4, Title="Read 10 pages from Atomic Habbits", Description="lorem ipsum", IsCompleted = false },
      ]

    };
  }

  public async Task<Response<TodoDTO>> GetAsync(int id) {
    throw new NotImplementedException();
  }
  #endregion
}