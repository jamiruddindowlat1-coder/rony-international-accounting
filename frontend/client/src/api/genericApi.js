import axiosClient from './axiosClient'

// Every entity in the schema gets working Create/Read/Update/Delete
// for free by pointing this factory at its controller's route.
// Example: const companyApi = createCrudApi('/Companies')
export function createCrudApi(endpoint) {
  return {
    getAll: () => axiosClient.get(endpoint).then((r) => r.data.data),
    getById: (id) => axiosClient.get(`${endpoint}/${id}`).then((r) => r.data.data),
    create: (payload) => axiosClient.post(endpoint, payload).then((r) => r.data.data),
    update: (id, payload) => axiosClient.put(`${endpoint}/${id}`, payload).then((r) => r.data.data),
    remove: (id) => axiosClient.delete(`${endpoint}/${id}`),
  }
}
