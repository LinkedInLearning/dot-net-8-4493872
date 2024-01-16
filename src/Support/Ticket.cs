﻿namespace Support;

public record Ticket(Guid Id, string Titre, string Description, string Email, DateTime Cree, DateTime Modifie, Ticket.Etat EtatCourant = Ticket.Etat.Ouvert)
{
  public enum Etat
  {
    Ouvert,
    EnAttente,
    Resolu,
    Ferme
  }
}