using Domain.DTOs;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class HomePictureController : Controller
{
    private readonly IHomePictureRepository _homePictureRepository;

    public HomePictureController(IUnitOfWork unitOfWork)
    {
        _homePictureRepository = unitOfWork.HomePictureRepo();
    }

    public ActionResult Index()
    {
        var homePictures = _homePictureRepository.Load();
        return View(homePictures);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(HomePicture homePicture)
    {
        _homePictureRepository.Create(homePicture);
        return RedirectToAction("Index");
    }

    public ActionResult Edit(Guid id)
    {
        var homePicture = _homePictureRepository.Read(id);
        return View(homePicture);
    }

    [HttpPost]
    public ActionResult Edit(HomePicture homePicture)
    {
        _homePictureRepository.Update(homePicture);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(Guid id)
    {
        _homePictureRepository.Delete(id);
        return RedirectToAction("Index");
    }
}
