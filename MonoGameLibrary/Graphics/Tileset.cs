﻿namespace MonoGameLibrary.Graphics;

public class Tileset
{
    private readonly TextureRegion[] _tiles;
    
    /// <summary>
    /// Get the width in pixels of each tile in this tileset.
    /// </summary>
    public int TileWidth { get; }
    
    /// <summary>
    /// Get the height in pixels of each tile in this tileset.
    /// </summary>
    public int TileHeight { get; }
    
    /// <summary>
    /// Get the total number of columns in this tileset.
    /// </summary>
    public int Columns { get; }
    
    /// <summary>
    /// Get the total number of rows in this tileset.
    /// </summary>
    public int Rows { get; }
    
    /// <summary>
    /// Get the total number of tiles in this tileset.
    /// </summary>
    public int Count { get; }

    /// <summary>
    /// Creates a new tileset based on the given texture region and tile width and height.
    /// </summary>
    /// <param name="textureRegion">The texture region that contains the tiles in this tileset.</param>
    /// <param name="tileWidth">The width in pixels for each tile in this tileset.</param>
    /// <param name="tileHeight">The width in pixels for each tile in this tileset.</param>
    public Tileset(TextureRegion textureRegion, int tileWidth, int tileHeight)
    {
        TileWidth = tileHeight;
        TileHeight = tileHeight;
        Columns = textureRegion.Width / TileWidth;
        Rows = textureRegion.Height / TileHeight;
        Count = Columns * Rows;

        _tiles = new TextureRegion[Count];

        for (int i = 0; i < Count; i++)
        {
            int x = i % Columns * tileWidth;
            int y = i / Columns * tileHeight;
            _tiles[i] = new TextureRegion(textureRegion.Texture, textureRegion.SourceRectangle.X + x, textureRegion.SourceRectangle.Y + y, tileWidth, tileHeight);
        }
    }

    /// <summary>
    /// Gets the texture region for the tile from this tileset at the given index.
    /// </summary>
    /// <param name="index">The index of the texture region in this tile set.</param>
    /// <returns>The texture region for the tile form this tileset at the given index.</returns>
    public TextureRegion GetTile(int index) => _tiles[index];

    /// <summary>
    /// Gets the texture region for the tile from this tileset at the given location.
    /// </summary>
    /// <param name="column">The column in this tileset of the texture region.</param>
    /// <param name="row">The row in this tileset of the texture region.</param>
    /// <returns>The texture region for the tile from this tileset at given location.</returns>
    public TextureRegion GetTile(int column, int row)
    {
        int index = row * Columns + column;
        return GetTile(index);
    }

}