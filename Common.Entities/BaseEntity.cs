﻿namespace Common.Entities
{
    public class BaseEntity
    {
        protected BaseEntity(Guid id) => Id = id;

        protected BaseEntity()
        {
        }

        public Guid Id { get; private init; }

        public static bool operator ==(BaseEntity? first, BaseEntity? second) =>
            first is not null && second is not null && first.Equals(second);

        public static bool operator !=(BaseEntity? first, BaseEntity? second) =>
            !(first == second);

        public bool Equals(BaseEntity? other)
        {
            if (other is null)
            {
                return false;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return other.Id == Id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            if (obj is not BaseEntity entity)
            {
                return false;
            }

            return entity.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode() * 41;
    }
}
