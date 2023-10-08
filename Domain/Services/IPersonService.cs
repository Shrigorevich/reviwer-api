namespace Domain.Services;

public interface IPersonService
{
    Task<IMethodResponse<int>> CreatePerson(PersonDraftDto person);

    Task<IMethodResponse<PersonDto>> GetPersonById(int id);

    // TODO: How to return not typified MethodResponse
    Task<IMethodResponse<PersonDto>> UpdatePerson(PersonDraftDto person);

    Task<IMethodResponse<List<PersonDto>>> GetPersons();
}