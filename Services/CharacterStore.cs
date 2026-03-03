using System.Text.Json;
using DeathwatchMobile.Models;
using Microsoft.JSInterop;

namespace DeathwatchMobile.Services;

public sealed class CharacterStore
{
    private const string Key = "dw_characters_v1";
    private readonly IJSRuntime _js;

    public CharacterStore(IJSRuntime js) => _js = js;

    public async Task<List<Character>> GetAllAsync()
    {
        var json = await _js.InvokeAsync<string?>("localStorage.getItem", Key);
        if (string.IsNullOrWhiteSpace(json)) return new List<Character>();
        return JsonSerializer.Deserialize<List<Character>>(json) ?? new List<Character>();
    }

    public async Task SaveAllAsync(List<Character> characters)
    {
        var json = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = false });
        await _js.InvokeVoidAsync("localStorage.setItem", Key, json);
    }

    public async Task<Character?> GetByIdAsync(string id)
        => (await GetAllAsync()).FirstOrDefault(c => c.Id == id);

    public async Task UpsertAsync(Character character)
    {
        var all = await GetAllAsync();
        var idx = all.FindIndex(c => c.Id == character.Id);
        character.UpdatedUtc = DateTime.UtcNow;

        if (idx >= 0) all[idx] = character;
        else all.Add(character);

        await SaveAllAsync(all);
    }

    public async Task DeleteAsync(string id)
    {
        var all = await GetAllAsync();
        all.RemoveAll(c => c.Id == id);
        await SaveAllAsync(all);
    }
}