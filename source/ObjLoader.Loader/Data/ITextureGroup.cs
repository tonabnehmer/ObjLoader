namespace ObjLoader.Loader.Data
{
    public interface ITextureGroup
    {
        Texture GetTexture(int i);
        void AddTexture(Texture texture);
    }
}