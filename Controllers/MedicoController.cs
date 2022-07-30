using Microsoft.AspNetCore.Mvc;
using Unidades_De_Saude.Data.Entities;
using Unidades_De_Saude.ModelViewModel;
using Unidades_De_Saude.Repositories;

namespace Unidades_De_Saude.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public IActionResult Index()
        {
            var medicos = _medicoRepository.GetAll();
            MedicoViewModel model = new MedicoViewModel();          
            return View(model.GetListDatabase(medicos.ToList()));
        }
        public IActionResult EspecialidadesIndex()
        {
            EspecialidadesViewModel especialidades = new EspecialidadesViewModel();
            var objs = _medicoRepository.GetEspecialidades();

            return View(especialidades.GetListDatabase(objs));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MedicoViewModel model)
        {
            if (ModelState.IsValid)
            {
                Medico medico = new Medico();
                model.UpdateDatabse(medico);
                _medicoRepository.Add(medico);
            }
            return RedirectToAction("Index");
        }
    }
}
