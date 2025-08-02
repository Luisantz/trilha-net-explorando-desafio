using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte (Valor de diaria alterado para 60)
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 60);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes,valor da diária e quantidade de dias reservados
Console.WriteLine($"👥 Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()} ⇦");
Console.WriteLine($"🧾 Valor Diária: {reserva.CalcularValorDiaria():C} ⇦");
Console.WriteLine($"📆 Quantidade de dias reservados: {reserva.ObterQuantidadeDias()} ⇦");
