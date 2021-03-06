﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using english_learning_app.Models;

namespace english_learning_app.Data
{
    public interface IFlashcardDataRepository
    {
        public Task<Deck> AddDeck(string deckName);

        public Task<List<Deck>> GetAllDecks();

        public Task<Deck> GetDeckById(int deckId);

        public Task<bool> isDeckExist(int deckId);

        public Task<List<Card>> GetCardsByDeckId(int deckId);

        public Task<Card> AddCardToDeck(int deckId, string questionText, string answerText);

        public Task<Card> GetCardFromDeckByCardId(int deckId, int cardId);

        public Task<bool> DeleteDeckById(int deckId);

        public Task<bool> UpdateDeckNameById(int id, string name);

        public Task<bool> DeleteCardFromDeckByCardId(int deckId, int cardId);

        public Task<bool> UpdateCardFromDeckByCardId(int deckId, int cardId, string questionText, string answerText);

    }
}
