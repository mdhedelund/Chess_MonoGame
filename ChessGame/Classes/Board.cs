﻿using System;
using System.Collections.Generic;
using ChessGame.Utilities;

namespace ChessGame.Classes;

public class Board
{
    public enum GameType
    {
        Standard,
        Chess960
    }
    
    private int[] _pieceIds;
    public int[] PieceIds => _pieceIds;

    public Board(GameType gameType = GameType.Standard)
    {
        switch (gameType)
        {
            case GameType.Standard:
                _pieceIds = BoardSetups.StandardSetup;
                break;
            case GameType.Chess960:
                // TODO: Implement Chess960 board generation
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(gameType), gameType, null);
        }
    }
}