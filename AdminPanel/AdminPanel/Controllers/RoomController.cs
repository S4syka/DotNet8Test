using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.DTOs;

namespace AdminPanel.Controllers;

public class RoomController : Controller
{
    private readonly IRoomRepository _roomRepository;

    public RoomController(IUnitOfWork unitOfWork)
    {
        _roomRepository = unitOfWork.RoomRepo();
    }

    public ActionResult Index()
    {
        var rooms = _roomRepository.Load();
        return View(rooms);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Room room)
    {
        _roomRepository.Create(room);
        return RedirectToAction("Index");
    }

    public ActionResult Edit(Guid id)
    {
        var room = _roomRepository.Read(id);
        return View(room);
    }

    [HttpPost]
    public ActionResult Edit(Room room)
    {
        _roomRepository.Update(room);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(Guid id)
    {
        _roomRepository.Delete(id);
        return RedirectToAction("Index");
    }
}
