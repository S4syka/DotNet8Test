using Domain.DTOs;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class FoodController : Controller
{
    private readonly IFoodRepository _foodRepository;

    public FoodController(IUnitOfWork unitOfWork)
    {
        _foodRepository = unitOfWork.FoodRepo();
    }

    public ActionResult Index()
    {
        var rooms = _foodRepository.Load();
        return View(rooms);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Food food)
    {
        _foodRepository.Create(food);
        return RedirectToAction("Index");
    }

    public ActionResult Edit(Guid id)
    {
        var food = _foodRepository.Read(id);
        return View(food);
    }

    [HttpPost]
    public ActionResult Edit(Food food)
    {
        _foodRepository.Update(food);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(Guid id)
    {
        _foodRepository.Delete(id);
        return RedirectToAction("Index");
    }
}
