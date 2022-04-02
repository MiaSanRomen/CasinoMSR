using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryPedia.Models;

namespace CasinoMSR.Web.Data
{
    public static class DataClass
    {

        public static Game TempGame = new Game();
        public static BlockInfo TempBlock = new BlockInfo();
        public static List<BlockInfo> BlocksTempList = new List<BlockInfo>();
        public static List<Picture> ImagesTempList = new List<Picture>();

        public static void Initialize(GameContext context)
        {
            if (!context.Games.Any())
            {
                context.Games.AddRange(
                    new Game
                    {
                        Name = "Blackjack",
                        View = "Blackjack",
                        Year = 2019,
                        TypeName = "Cards",
                        Recommendations = 0,
                        ImageName = "BlackJack",
                        Genre = GenreEnum.Cards,
                        Info = 
                            "Blackjack (formerly Black Jack and Vingt - Un) is a casino banking game. The most widely played casino banking game in the world, it uses decks of 52 cards and descends from a global family of casino banking games known as Twenty - One.This family of card games also includes the British game of Pontoon and the European game, Vingt - et - Un. Blackjack players do not compete against each other. The game is a comparing card game where each player competes against the dealer."
                    },
                    new Game
                    {
                        Name = "Caesar",
                        View = "Caesar",
                        Year = 2018,
                        TypeName = "Slots",
                        Recommendations = 0,
                        ImageName = "Caesar",
                        Genre = GenreEnum.Slots,
                        Info =
                            "A slot machine (American English), known variously as a fruit machine (British English), puggy (Scottish English), the slots (Canadian English and American English), poker machine/pokies (Australian English and New Zealand English), fruities (British English) or slots (American English), is a gambling machine that creates a game of chance for its customers. Slot machines are also known pejoratively as one-armed bandits because of the large mechanical levers affixed to the sides of early mechanical machines and the games' ability to empty players' pockets and wallets as thieves would."
                    }, 
                    new Game
                    {
                        Name = "Pirates' Gold",
                        View = "Pirates",
                        Year = 2021,
                        TypeName = "Slots",
                        Recommendations = 0,
                        ImageName = "Pirates' Gold",
                        Genre = GenreEnum.Slots,
                        Info =
                            "A slot machine (American English), known variously as a fruit machine (British English), puggy (Scottish English), the slots (Canadian English and American English), poker machine/pokies (Australian English and New Zealand English), fruities (British English) or slots (American English), is a gambling machine that creates a game of chance for its customers. Slot machines are also known pejoratively as one-armed bandits because of the large mechanical levers affixed to the sides of early mechanical machines and the games' ability to empty players' pockets and wallets as thieves would."

                    },
                    new Game
                    {
                        Name = "Secret of Egypt",
                        View = "Egypt",
                        Year = 2022,
                        TypeName = "Slots",
                        Recommendations = 0,
                        ImageName = "Secret of Egypt",
                        Genre = GenreEnum.Slots,
                        Info =
                            "A slot machine (American English), known variously as a fruit machine (British English), puggy (Scottish English), the slots (Canadian English and American English), poker machine/pokies (Australian English and New Zealand English), fruities (British English) or slots (American English), is a gambling machine that creates a game of chance for its customers. Slot machines are also known pejoratively as one-armed bandits because of the large mechanical levers affixed to the sides of early mechanical machines and the games' ability to empty players' pockets and wallets as thieves would."
                    },
                    new Game
                    {
                        Name = "Roulette",
                        View = "Roulette",
                        Year = 2022,
                        TypeName = "Other",
                        Recommendations = 0,
                        ImageName = "Roulette",
                        Genre = GenreEnum.Other,
                        Info =
                            "Roulette is a casino game named after the French word meaning little wheel which was likely developed from the Italian game Biribi. In the game, a player may choose to place a bet on a single number, various groupings of numbers, the color red or black, whether the number is odd or even, or if the numbers are high (19–36) or low (1–18)."
                    }
                );
                context.SaveChanges();
            }

            if (!context.Genres.Any())
            {
                context.Genres.AddRange(
                    new Genre
                    {
                        GenreName = "Slots",
                    },
                    new Genre
                    {
                        GenreName = "Cards",
                    },
                    new Genre
                    {
                        GenreName = "Other",
                    });
            }

            if (!context.Pictures.Any())
            {
                context.Pictures.AddRange(
                    new Picture()
                    {
                        PictureName = "BlackJack",
                        Path = "/Images/black-jack_ico.png",
                    },
                    new Picture()
                    {
                        PictureName = "Caesar",
                        Path = "/Images/caesar-slots_ico.jpg",
                    },
                    new Picture()
                    {
                        PictureName = "Pirates' Gold",
                        Path = "/Images/pirate-slots_ico.png",
                    },
                    new Picture()
                    {
                        PictureName = "Secret of Egypt",
                        Path = "/Images/egypt-slots_ico.jpg",
                    },
                    new Picture()
                    {
                        PictureName = "Roulette",
                        Path = "/Images/roulette_ico.jpg",
                    },
                    new Picture()
                    {
                        PictureName = "Admin",
                        Path = "/Images/Winner.jpeg",
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
